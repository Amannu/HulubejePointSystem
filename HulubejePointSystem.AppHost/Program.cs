var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.HulubejePointSystem>("hulubejepointsystem");

builder.Build().Run();
