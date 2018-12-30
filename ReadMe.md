# CleanStartCore: Clean Start for Asp.Net Core 2.2

This is my squeaky clean CRUD'er boilerplate for a DDD approach using .Net Core, CQRS, Fluent Validation, Mediator and Entity Framework.  I should have forked this but instead I started a clean solution and followed the Native South Pacific Texan (Australian) [Jason Tau](http://bit.ly/2RghbjJ)'s NorthwWind revamp work he did for his presentation at the [SSWTV](https://tv.ssw.com) back in October 2018.  Here is a link to the presentation.  

[Clean Architecture w/ ASP.Net Core 2.1](https://youtu.be/_lwCVE_XgqI)

Feel free to take and tweak what you find useful.  It's a can be a good starting point for an application.  Please feel free to review it as needed.  I wrote it from scratch using the Jason's NorthWind project as a guidewire.

Note: The Intermediary class is a domain entity, that maps to an application model.  I based it off customers in the NorthWind DB. Just sharing this out there just 'cuz.  

As far as a roadmap goes, going to bake in some T-4 templating to ease the burden of creating the query, commands, various handlers and validates that need to get created for each entity.  Also bake in application interfaces for S3, lambdas and step functions in AWS.  

Jason is still turning an burning on his NorthWind implementation.  His project [NorthWind Traders](https://github.com/JasonGT/NorthwindTraders) was used as a reference to create this, so props are PIF now!

Thanks, 

Mike Mahon
[@jetstreamin](http://bit.ly/2RmcjJF)
