# Service Discovery

Service discovery using Steeltoe


## Prerequisites:

- Install Spring Eureka

## Solution description


| Project                      | Description                                                                                                                                                                                                             |
| ---------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Discovery.UI`           | Web project that tries to discover a greetings service. Displays a greeting message |
| `Discovery.Service`     | Service that exposes a greetings service. This service registers itself with Eureka when starting up                                                                                                                                                                                                      |