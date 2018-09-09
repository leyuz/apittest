Core Project

In the core project, we keep the entities and the repository interfaces or the database operation interfaces. The core project contains information about the domain entities and the database operations required on the domain entities. In an ideal scenario, the core project should not have any dependencies on external libraries. It must not have any business logic, database operation codes etc.

In short, the core project should contain:

Domain entities
Repository interfaces or database operations interfaces on domain entities
Domain-specific data annotations


The core project can NOT contain:

Any external libraries for database operations
Business logic
Database operations code