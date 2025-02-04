# Challenges

1. How can we ensure that all stake-holders, from the various teams (Products, Security, Data Engineering, QA, Data Ops and Software Ops etc), are informed about solutioning decisions and have a well defined channel for providing feedback?

2. How do we improve solutioning and development speed? E.g:

   - Better facilitate the communication and flow between Products, UI/UX, Engineering and QA.
   - Eliminate bottlenecks (e.g. relying on single key individuals in order to move)

3. How do we enable engineers to become more autonomous with solutioning, while keeping consistency, quality and long term visions in mind?

   - Design patterns.
   - Review Cycles.
   - High level directional goals.
   - …

4. How can we ensure that each engineering initiative have properly considered the “Non functional” Design Characteristics ( “Illities” ) of the implementation? E.g. (non-exhaustive):

   - Implementation Effort, including QA, UAT etc

     (we want to be more structured and consistent on how we do this)

   - Operating Cost

     - Infra

       (incl. things like Wiz)

     - Operations

   - Agility

     - Deployability
     - Configurability
     - Maintainability

   - Extensibility

     - Modularity / Reusablity
     - Composability / “Pluggability”

   - Consistency / Usability

     (e.g. naming conventions, error codes)

   - Observability

     - Monitoring (Metrics)
     - Traceability (Log Tracing)
     - Alerts

   - Performance and Scalability

     - Latency (time taken to respond to a request)
     - Throughput (number of request that can be handled per hour)
     - Elasiticity (ability to scale up and down resources based on load)

   - Security

     - Auditability
     - Conforming to policies and legislation
     - Authentication (users as well as personnel)
     - Authorization (users as well as personnel)

   - Availability / Durability / Resiliency

     - Replication
     - Fault Tolerance
     - Recoverability

   - …

5. How to ensure that documentation (both AS-IS and TO-BE) documentation is up to date?

6. How to minimize overhead of keeping documentation up to date? E.g:

   - When something changes, we want to update in as few places as possible
   - For hand drawn diagrams, a small change can require that the whole diagram needs to be refactored (which is time consuming)

7. How can we ensure that everyone knows where to find the relevant solutioning documentation (both AS-IS and TO-BE)?

8. How can we enforce consistency and legibility between documentations, particularly when written by many different authors?
   - Which documents that should be produced and what they should, and should not, contain.
   - Terminology
   - Symbols / Arrows / Labels
   - etc

## Additional practical things to solve in 2025:

- Versioning of services (having multiple versions available)

- Ensure that all engineers have up to date and consistent Postman collections for all our internal API endpoints

- Shorter cycle to get external APIs onto Development portal

- Streamline and standardize DevOps processes, eg:

  - How we split our code between repositories.

  - Standardized process for creating and structuring repositories.

    E.g. Only create repositories using Terraform (not manually), with automatically configured branch protection and requirements for PR tests etc, use Projen for creating and maintaining boilerplate for mono- or poly- repo structure, publishing actions etc, and use of ChangeSets etc.

- Disaster Recovery
