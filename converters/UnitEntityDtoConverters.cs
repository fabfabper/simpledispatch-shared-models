using SimpleDispatch.SharedModels.Entities;
using SimpleDispatch.SharedModels.Dtos;

namespace SimpleDispatch.SharedModels.Converters
{
    public static class UnitEntityDtoConverters
    {
        public static Dtos.Unit ToDto(Entities.Unit entity)
        {
            if (entity == null) return null!;
            return new Dtos.Unit
            {
                Id = entity.Id,
                Status = entity.Status,
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

        public static Entities.Unit ToEntity(Dtos.Unit dto)
        {
            if (dto == null) return null!;
            return new Entities.Unit
            {
                Id = dto.Id,
                Status = dto.Status,
                Type = dto.Type,
                Latitude = dto.Position?.Latitude,
                Longitude = dto.Position?.Longitude
            };
        }
    }
}
