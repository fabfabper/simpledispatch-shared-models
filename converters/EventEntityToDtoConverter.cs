using SimpleDispatch.SharedModels.Entities;
using SimpleDispatch.SharedModels.Dtos;
using System.Security.Cryptography.X509Certificates;

namespace SimpleDispatch.SharedModels.Converters
{
    public static class EventEntityToDtoConverter
    {
        public static Dtos.Event ToDto(Entities.Event entity)
        {
            if (entity == null) return null!;
            return new Dtos.Event
            {
                Id = entity.Id,
                Location = entity.Location,
                Type = entity.Type,
                Position = entity.Latitude.HasValue && entity.Longitude.HasValue
                    ? new Coordinate
                    {
                        Latitude = entity.Latitude.Value,
                        Longitude = entity.Longitude.Value
                    }
                    : null
            };
        }
    }
}
