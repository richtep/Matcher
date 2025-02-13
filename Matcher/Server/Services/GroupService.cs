﻿using EntitySystem.Server.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Server.Services;

public class GroupService : EntityService<Group>
{
    public GroupService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}