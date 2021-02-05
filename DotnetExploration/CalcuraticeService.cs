using AutoMapper;

namespace DotnetExploration
{
    public class CalcuraticeService : ICalculatriceService
    {
        private readonly IMapper _mapper;

        public CalcuraticeService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Model2Extrant Additionner(Model2Intrant model2)
        {
            var m3 = _mapper.Map<Model3Intrant>(model2);

            var m3e = new Model3Extrant
            {
                Restult = m3.X + m3.Y
            };

            return _mapper.Map<Model2Extrant>(m3e);
        }
    }
}