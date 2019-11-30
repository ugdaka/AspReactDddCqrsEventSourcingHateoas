# YNGSTR

>  Containers based microservices architecture application, cross-platform on Linux and Windows, powered by .NET Core 2.2, Docker engine, Domain-Driven Design, Functional Programming and TDD. 

## Features
- [x] Microservices architecture
 The backend is structured as a collection of web services that are:
  - Highly maintainable and testable
  - Loosely coupled
  - Independently deployable
  - Organized around business requirements
  
![alt text](https://raw.githubusercontent.com/profjordanov/AspReactDddCqrsEventSourcingHateoas/master/resources/architecture_overview.png)


- [x] Domain-Driven Design done by the book, demonstrated by the following concepts:
  - Bounded contexts
  - Ubiqutous language
  
- [x] Command Query Responsibility Segregation

- [x] Functional style command/query handlers

- [x] Event-sourcing

- [x] Complete tests suite (unit and integration)

- [x] Docker CI setup with multiple data sources

- [x] REST with [HATEOAS](https://en.wikipedia.org/wiki/HATEOAS)

- [x] Asynchronous communication via RabbitMQ
  
- [x] Swagger UI + Fully Documented Controllers

- [x] Thin Controllers

- [x] AutoMapper

- [x] EntityFramework Core with PostgreSQL

- [x] Stylecop

- [x] Neat folder structure

```
├───backend
│   ├───common
│   │   ├───YngStrs.Common.Api
│   │   ├───YngStrs.Common.Cqrs
│   │   ├───YngStrs.Common.EventSourcing
│   │   ├───YngStrs.Common.Hateoas
│   │   └───YngStrs.Common
│   ├───configuration
│       ├───analyzers.ruleset
│       └───stylecop.json
│   ├───services
│       ├───YngStrs.Chatbot.Api
│       ├───YngStrs.Customers.Api
│       ├───YngStrs.PersonalityTests.Api
│       ├───YngStrs.Identity.Api
│       ├───YngStrs.Downloads.Api
│       └───YngStrs.Contents.Api
│   └───workers
│       ├───YngStrs.EmailWorker.Api
│       └───YngStrs.ReportsWorker.Api
└─── frontend
    └───Conduit.Business.Tests
```

