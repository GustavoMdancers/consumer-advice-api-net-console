using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ConsumerAdviceApi.Models;

namespace ConsumerAdviceApi;

internal class Program
{
    private static async Task Main(string[] args)
    {
        const string endpoint = "https://api.adviceslip.com/advice";

        Console.WriteLine("Iniciando requisição para obter dados de um conselho:");
        Console.WriteLine();
        Console.WriteLine(endpoint);
        Console.WriteLine();

        using var httpClient = new HttpClient();

        try
        {
            // Consome o endpoint fornecido
            string jsonResponse = await httpClient.GetStringAsync(endpoint);

            // Desserializa a resposta JSON para o modelo tipado
            var result = JsonSerializer.Deserialize<AdviceSlipResponse>(jsonResponse);

            if (result?.Slip != null && !string.IsNullOrWhiteSpace(result.Slip.Advice))
            {
                // Exibe os dados retornados no formato especificado
                Console.WriteLine("Conselho de Hoje:");
                Console.WriteLine(result.Slip.Advice);
            }
            else
            {
                Console.WriteLine("Não foi possível processar o conselho retornado.");
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Erro ao desserializar os dados: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
    }
}
