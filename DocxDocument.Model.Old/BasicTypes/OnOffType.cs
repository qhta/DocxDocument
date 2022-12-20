namespace DocxDocument.Model;

public struct OnOffType
{
  private bool? value;

  public static implicit operator bool?(OnOffType val) => val.value;

  public static implicit operator OnOffType?(bool? val) => (val!=null) ? new OnOffType{value = val} : null;
}