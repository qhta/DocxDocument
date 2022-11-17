namespace DocumentModel.Office.Word;

public interface IFixedCommandKeyboardCustomization // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? CommandName { get ; set; }

  public IHexBinaryValue? CommandIndex { get ; set; }

  public IHexBinaryValue? Argument { get ; set; }

}
