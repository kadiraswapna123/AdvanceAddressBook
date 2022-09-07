using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    public class ReadOrWriteDatabase
    {
        public object RestAssured { get; private set; }

        public void WeatherMessageBody()
		{
			RestAssured.baseURI = "https://restapi.demoqa.com/utilities/weather/city";
			RequestSpecification httpRequest = RestAssured.given();
			Response response = httpRequest.get("/Hyderabad");

			// Retrieve the body of the Response
			ResponseBody body = response.getBody();

			// By using the ResponseBody.asString() method, we can convert the  body
			// into the string representation.
			System.out.println("Response Body is: " + body.asString());
		}

	}
}
