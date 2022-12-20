namespace DocxDocument.Model;

public class ListLevelStyleNumber: ListLevelStyleText
{
  public string? NumFormat { get; set; }
  public NumLetterSync? NumLetterSync { get; set; }
  public string? DisplayLevels { get; set; }
  public int? StartValue { get; set; }

}