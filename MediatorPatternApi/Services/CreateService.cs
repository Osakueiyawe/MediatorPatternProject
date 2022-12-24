using MediatR;
namespace MediatorPatternApi.Services
{
    public class CreateRequest:IRequest<CreateResponse>
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }

    public class CreateResponse
    {
        public string responseCode { get; set; }
        public string responseMessage { get; set; }
    }
    public class CreateService:IRequestHandler<CreateRequest,CreateResponse>
    {
        public async Task<CreateResponse> Handle(CreateRequest request, CancellationToken cancellationToken)
        {
            CreateResponse response = new CreateResponse();
            try
            {
                if(request.id == "1")
                {
                    response.responseCode = "00";
                    response.responseMessage = "successful";
                }
            }
            catch(Exception ex)
            {

            }
            return response;
        }
    }
}
