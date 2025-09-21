using SimpleDispatch.SharedModels.Entities;
using SimpleDispatch.SharedModels.Dtos;

namespace SimpleDispatch.SharedModels.Converters
{
    public static class UnitEntityToDtoConverter
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
    }
}
