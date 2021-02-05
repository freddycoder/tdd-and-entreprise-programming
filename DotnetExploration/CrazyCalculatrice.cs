using AutoMapper;

namespace DotnetExploration
{
    public class CrazyCalculatrice
    {
        private readonly ICalculatriceService _calculatriceService;
        private readonly IMapper _mapper;

        public CrazyCalculatrice(ICalculatriceService calculatriceService, IMapper mapper)
        {
            _calculatriceService = calculatriceService;
            _mapper = mapper;
        }

        public Model1Extrant Additionner(Model1Intrant model1)
        {
            var m2 = _mapper.Map<Model2Intrant>(model1);

            var result = _calculatriceService.Additionner(m2);

            return _mapper.Map<Model1Extrant>(result);
        }
    }
}
