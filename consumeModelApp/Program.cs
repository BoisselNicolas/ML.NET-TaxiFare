using System;
using SampleRegression.Model;

namespace consumeModelApp {

    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput(){
                Vendor_id = "CMT",
                Rate_code = Convert.ToSingle(1.0),
                Passenger_count = Convert.ToSingle(2.0),
                Trip_time_in_secs = Convert.ToSingle(2000.0),
                Trip_distance = Convert.ToSingle(5.0),
                Payment_type = "CRD"
            };

            ModelOutput result = ConsumeModel.Predict(input);
            string fare_amount = result.Score.ToString();
            Console.WriteLine($"vendor_id {input.Vendor_id}\n rate_code {input.Rate_code}\n passenger_count {input.Passenger_count}\n trip_time_in_secs {input.Trip_time_in_secs}\n trip_distance {input.Trip_distance}\n payment_type {input.Payment_type}\n fare_amount : {fare_amount}");
        }
    }

}