﻿namespace Pets.Controllers.Animal.Actions.GetList
{
    using System.Collections.Generic;
    using Api.Requests.Abstractions;
    using Dto;

    public record AnimalGetListResponse : IResponse
    {
        public IEnumerable<AnimalListItemDto> Animals { get; init; }
    }
}
