using dev_test.DTOs;
using dev_test.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace dev_test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SurveyController : Controller
    {
        public ISurveyService _surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpGet]
        public IEnumerable<SurveyDto> GetSurveys()
        {
            return _surveyService.GetSurveys();
        }

        [HttpPost]
        public bool PostSurveys(SurveyCompositeDto surveyComposite)
        {
            try
            {
                _surveyService.PostSurveys(surveyComposite);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
