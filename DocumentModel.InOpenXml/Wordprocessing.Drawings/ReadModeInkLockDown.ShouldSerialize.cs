namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class ReadModeInkLockDown
{
  public bool ShouldSerializeUseActualPages() => UseActualPages is not null;
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeFontSize() => FontSize is not null;
}
