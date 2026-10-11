using EdutotsSchools.Models;

namespace EdutotsSchools.Services;

public class SchoolService
{
    private readonly HttpClient _http;

    public SchoolService(HttpClient http)
    {
        _http = http;
    }

    /// <summary>
    /// GET api/school and deserialize the JSON array into School models.
    /// GetFromJsonAsync uses web defaults, so camelCase JSON maps to PascalCase properties.
    /// Throws HttpRequestException / JsonException / TaskCanceledException on failure.
    /// </summary>
    public async Task<List<School>> GetSchoolsAsync(CancellationToken cancellationToken = default)
    {
        var schools = await _http.GetFromJsonAsync<List<School>>("api/school", cancellationToken);
        return schools ?? new List<School>();
    }
}
