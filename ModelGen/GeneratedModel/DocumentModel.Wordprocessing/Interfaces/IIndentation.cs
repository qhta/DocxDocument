namespace DocumentModel.Wordprocessing;

public interface IIndentation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Left { get ; set; }

  public string? Start { get ; set; }

  public int? LeftChars { get ; set; }

  public int? StartCharacters { get ; set; }

  public string? Right { get ; set; }

  public string? End { get ; set; }

  public int? RightChars { get ; set; }

  public int? EndCharacters { get ; set; }

  public string? Hanging { get ; set; }

  public int? HangingChars { get ; set; }

  public string? FirstLine { get ; set; }

  public int? FirstLineChars { get ; set; }

}
