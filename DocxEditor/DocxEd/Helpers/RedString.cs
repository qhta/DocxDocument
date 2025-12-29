namespace DocxEd.Helpers
{
  public struct RedString
  {
    public RedString(string? value)
    {
      Value = value;
    }
    public string? Value { [DebuggerStepThrough] get; set; }

    public override string? ToString() => Value;
  }
}
