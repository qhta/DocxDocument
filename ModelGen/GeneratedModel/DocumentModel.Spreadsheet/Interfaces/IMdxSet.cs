namespace DocumentModel.Spreadsheet;

public interface IMdxSet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? SetDefinitionIndex { get ; set; }

  public uint? MemberIndexCount { get ; set; }

  public MdxSetOrder? SortingOrder { get ; set; }

}
