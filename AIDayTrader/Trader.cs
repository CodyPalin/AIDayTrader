using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

public class Trader
{
    class buy
    {
        public string symbol;
        public int qty;
        public string side;
        public string type;
        public string time_in_force;
        public string limit_price; //number
        public string stop_price; //number
        public string trail_price; //number
        public string trail_percent; //number
        public string extended_hours;
        public string client_order_id; //autogened?
        public string order_class;
        //objects for take_profit and stop_loss
    }
    private string endpoint;
    private string apiKeyId;
    private string apiSecretKey;
	public Trader(string endpoint, string apiKeyId, string apiSecretKey)
	{
        this.endpoint = endpoint;
        this.apiKeyId = apiKeyId;
        this.apiSecretKey = apiSecretKey;
	}
    public MarketBuy(string symbol, int qty, string time_in_force = "day")
    {

    }
}
