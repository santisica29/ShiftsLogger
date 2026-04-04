namespace UI;

internal class ShiftService
{
    private readonly ApiService _apiService;

    public ShiftService(ApiService apiService)
    {
        _apiService = apiService;
    }

    //public async Task<Shift> GetShift()
    //{
    //    var response = await _apiService.GetAsync<Shift>()
    //}
}
