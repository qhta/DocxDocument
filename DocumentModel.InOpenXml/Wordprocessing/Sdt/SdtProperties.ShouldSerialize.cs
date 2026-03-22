namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class SdtProperties
{
  public bool ShouldSerializeSdtId() => SdtId is not null;
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeSdtAlias() => SdtAlias is not null;
  public bool ShouldSerializeLock() => Lock is not null;
  public bool ShouldSerializeSdtPlaceholder() => SdtPlaceholder is not null;
  public bool ShouldSerializeShowingPlaceholder() => ShowingPlaceholder is not null;
  public bool ShouldSerializeDataBinding() => DataBinding is not null;
  public bool ShouldSerializeTemporarySdt() => TemporarySdt is not null;
  public bool ShouldSerializeTag() => Tag is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeAppearance() => Appearance is not null;
  public bool ShouldSerializeWebExtensionLinked() => WebExtensionLinked is not null;
  public bool ShouldSerializeWebExtensionCreated() => WebExtensionCreated is not null;
  public bool ShouldSerializeSdtContentEquation() => SdtContentEquation is not null;
  public bool ShouldSerializeSdtContentPicture() => SdtContentPicture is not null;
  public bool ShouldSerializeSdtContentRichText() => SdtContentRichText is not null;
  public bool ShouldSerializeSdtContentCitation() => SdtContentCitation is not null;
  public bool ShouldSerializeSdtContentGroup() => SdtContentGroup is not null;
  public bool ShouldSerializeSdtContentBibliography() => SdtContentBibliography is not null;
  public bool ShouldSerializeEntityPickerEmpty() => EntityPickerEmpty is not null;
  public bool ShouldSerializeIsRepeatedSectionItem() => IsRepeatedSectionItem is not null;
  public bool ShouldSerializeSdtContentText() => SdtContentText is not null;
  public bool ShouldSerializeSdtContentCheckBox() => SdtContentCheckBox is not null;
  public bool ShouldSerializeSdtContentComboBox() => SdtContentComboBox is not null;
  public bool ShouldSerializeSdtContentDate() => SdtContentDate is not null;
  public bool ShouldSerializeSdtContentDocPartObject() => SdtContentDocPartObject is not null;
  public bool ShouldSerializeSdtContentDocPartList() => SdtContentDocPartList is not null;
  public bool ShouldSerializeSdtContentDropDownList() => SdtContentDropDownList is not null;
  public bool ShouldSerializeSdtRepeatedSection() => SdtRepeatedSection is not null;
}
