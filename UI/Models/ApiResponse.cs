namespace UI.Models;

internal record ApiResponse<T>
(
    T? Data,
    bool IsSuccessful,
    string? Message
);
