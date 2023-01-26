<Query Kind="Program" />

void Main()
{

	var service = new HelloService();
	var consumer = new ConsumerService();
	
	service.Print();
	
	consumer.Print();


}

public class HelloService
{
	public void Print(){
		"Inside Print".Dump();
	}

}

public class ConsumerService
{
	HelloService _helloService;
	public ConsumerService()
	{
		_helloService = new HelloService();		
	}
	
	public void Print()
	{
		_helloService.Print();
	}
	

}