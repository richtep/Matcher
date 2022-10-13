using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;

[Route("/api/item")]
public class ItemController : EntityController<ItemService, Item>
{
    public ItemController(ItemService entityService) : base(entityService)
    {
    }
}