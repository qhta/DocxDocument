namespace ModelGenApp.Helpers
{
  public struct RedString
  {
    public RedString(string? value)
    {
      Value = value;
    }
    public string? Value { get; set; }

    public override string? ToString() => Value;
  }
}
