namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtProperties
{
  public bool ShouldSerializeSdtId() => SdtId is not null && ShouldSerialize(SdtId);
  public bool ShouldSerializeRunProperties() => RunProperties is not null && ShouldSerialize(RunProperties);
  public bool ShouldSerializeSdtAlias() => !String.IsNullOrEmpty(SdtAlias);
  public bool ShouldSerializeLock() => Lock is not null && ShouldSerialize(Lock);
  public bool ShouldSerializeSdtPlaceholder() => SdtPlaceholder is not null && ShouldSerialize(SdtPlaceholder);
  public bool ShouldSerializeShowingPlaceholder() => ShowingPlaceholder is not null;
  public bool ShouldSerializeDataBinding() => DataBinding is not null && ShouldSerialize(DataBinding);
  public bool ShouldSerializeTemporarySdt() => TemporarySdt is not null;
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeColor() => Color is not null && ShouldSerialize(Color);
  public bool ShouldSerializeAppearance() => Appearance is not null && ShouldSerialize(Appearance);
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
  public bool ShouldSerializeSdtContentText() => SdtContentText is not null && ShouldSerialize(SdtContentText);
  public bool ShouldSerializeSdtContentCheckBox() => SdtContentCheckBox is not null && ShouldSerialize(SdtContentCheckBox);
  public bool ShouldSerializeSdtContentComboBox() => SdtContentComboBox is not null && ShouldSerialize(SdtContentComboBox);
  public bool ShouldSerializeSdtContentDate() => SdtContentDate is not null && ShouldSerialize(SdtContentDate);
  public bool ShouldSerializeSdtContentDocPartObject() => SdtContentDocPartObject is not null && ShouldSerialize(SdtContentDocPartObject);
  public bool ShouldSerializeSdtContentDocPartList() => SdtContentDocPartList is not null && ShouldSerialize(SdtContentDocPartList);
  public bool ShouldSerializeSdtContentDropDownList() => SdtContentDropDownList is not null && ShouldSerialize(SdtContentDropDownList);
  public bool ShouldSerializeSdtRepeatedSection() => SdtRepeatedSection is not null && ShouldSerialize(SdtRepeatedSection);
}
