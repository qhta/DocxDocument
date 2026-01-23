namespace DocumentModel.Wordprocessing;

public partial class SdtContentComboBox
{
  public bool ShouldSerializeLastValue() => LastValue is not null;
}
