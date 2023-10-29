namespace DocumentModel;

public record Setting
{
  public string? Name { get; set; }

  public object? Value { get; set; }
}
