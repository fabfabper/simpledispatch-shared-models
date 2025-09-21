using SimpleDispatch.SharedModels.Entities;
using SimpleDispatch.SharedModels.Dtos;

namespace SimpleDispatch.SharedModels.Converters
{
    public static class EventEntityDtoConverters
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

        public static Entities.Event ToEntity(Dtos.Event dto)
        {
            if (dto == null) return null!;
            return new Entities.Event
            {
                Id = dto.Id,
                Location = dto.Location,
                Type = dto.Type,
                Latitude = dto.Position?.Latitude,
                Longitude = dto.Position?.Longitude
            };
        }
    }
}
