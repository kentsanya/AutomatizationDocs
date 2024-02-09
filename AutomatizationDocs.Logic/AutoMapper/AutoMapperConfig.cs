using AutoMapper;

namespace AutomatizationDocs.Logic.AutoMapper
{
    internal static class AutoMapperConfig
    {
        private static MapperConfiguration _config;
        internal static IMapper Init()
        {
            if (_config == null)
            {
                _config = new MapperConfiguration(cfg=>cfg.AddProfile<MappingProfile>());
            }
            return _config.CreateMapper();
        }
    }
}
