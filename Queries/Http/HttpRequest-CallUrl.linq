<Query Kind="Statements">
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <IncludeAspNet>true</IncludeAspNet>
  <IncludeWinSDK>true</IncludeWinSDK>
</Query>

using System.Net;

var result = CallUrl("http://linkedin.com");
result.Dump(true);


async Task<string> CallUrl(string url)
{
	HttpClient http = new HttpClient();
	http.DefaultRequestHeaders.Accept.Clear();
	var response = http.GetStringAsync(url);
	return await response;
}