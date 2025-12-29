namespace DocxEd.Helpers
{
  public struct Description
  {
    public Description(string value)
    {
      Value = value;
    }
    public string Value { [DebuggerStepThrough] get; set; }

    public override string ToString() => Value;
  }
}
