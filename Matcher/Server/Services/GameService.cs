﻿using EntitySystem.Server.Services;
using Matcher.Shared;

namespace Matcher.Server.Services;

public class GameService : EntityService<Game>
{
    public GameService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}