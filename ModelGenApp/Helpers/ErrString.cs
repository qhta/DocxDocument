namespace ModelGenApp.Helpers
{
  public struct ErrString
  {
    public ErrString(string value)
    {
      Value = value;
    }
    public string Value { get; set; }

    public override string ToString() => Value;
  }
}
