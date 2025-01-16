// Repositories
public interface IRepository { }
public interface IXmlRepository : IRepository { 
    XmlDocument GetXml();
}

// Repositories.Impl
public abstract class BillingXmlRepository : IXmlRepository {
    protected long quoteID;

    public BillingXmlRepository(long quoteID) { 
        this.quoteID = quoteID;
    }

    public abstract XmlDocument GetXml();
}

public sealed class XmlInvoiceRepository : BillingXmlRepository { 
    public XmlInvoiceRepository(long quoteID) : base(quoteID) { }
    public override XmlDocument GetXml() { 
        // XML retrival here...
    }
}

// DataAggregation
pubilc interface IAggregatableData<T> { 
    T GetData();
}

public abstract class DataAggregator<T> : IAggregatableData<T> { 
    public abstract T GetData();
    protected abstract ICollection<IRepository> GetAllRequiredRepositories();
}

public abstract class XmlDataAggregator : DataAggregator<XmlDocument> { 
    public override XmlDocument GetData() { 
        XmlDocument root = new XmlDocument();
        foreach (IRepository repository in this.GetAllRequiredRepositories()) { 
            XmlDocument xml = (repository as IXmlRepository).GetXml();
            XmlDocumentFragment fragment = root.CreateDocumentFragment();
            fragment.InnerXml = xml.InnerXml;
            root.DocumentElement.AppendChild(fragment);
        }
        return root;
    }
}

public sealed class BillingDataAggregator : XmlDataAggregator {
    private long quoteID;

    public BillingDataAggregator(long quoteID) { 
        this.quoteID = quoteID;
    }

    protected override void ICollection<IRepository> GetAllRequiredRepositories() { 
        return new List<IRepository> { 
            new XmlBillingRepository(this.quoteID);
        }
    }
}

// Mappers to map raw XML to classes
public interface IMappable<T, K> { 
    T Map(K rawData);
}

public interface IXmlMappable<T> : IMappable<T, XmlDocument> { 
}

public sealed class BillingXmlMapper : IXmlMappable<BillingInfo> { 
    public BillingInfo Map(XmlDocument rawData) { 
        // LINQ code to traverse the XML and map it into a BillingInfo DTO
    }
}

// Entities
public sealed class BillingInfo { 
    // simple properties
}

// Consumer example
XmlDataAggregator aggregator = new BillingDataAggregator(1234);
var xml = aggregator.GetData();
var mapper = new BillingXmlMapper();
BillingInfo info = mapper.Map(xml);