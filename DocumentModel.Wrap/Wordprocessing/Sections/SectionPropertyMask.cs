namespace DocumentModel;

/// <summary>
/// Selector of section property.
/// </summary>
[Flags]
public enum SectionPropertyMask
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  HeaderReference             = 0x00000001,
  FooterReference             = 0x00000002,
  FootnoteProperties          = 0x00000004,
  EndnoteProperties           = 0x00000008,
  SectionType                 = 0x00000010,
  PageSize                    = 0x00000020,
  PageMargin                  = 0x00000040,
  PaperSource                 = 0x00000080,
  PageBorders                 = 0x00000100,
  LineNumberType              = 0x00000200,
  PageNumberType              = 0x00000400,
  Columns                     = 0x00000800,
  FormProtection              = 0x00001000,
  VerticalTextAlignmentOnPage = 0x00002000,
  NoEndnote                   = 0x00004000,
  TitlePage                   = 0x00008000,
  TextDirection               = 0x00010000,
  BiDi                        = 0x00020000,
  GutterOnRight               = 0x00040000,
  DocGrid                     = 0x00080000,
  PrinterSettingsReference    = 0x00100000,
  FootnoteColumns             = 0x00200000,
  SectionPropertiesChange     = 0x00400000,

  HeaderAndFooterReferences   = 0x00000003,
  FootnotAndeEndnote          = 0x0000000C,
  PageAndPaper                = 0x000001E0,
  NumberTypes                 = 0x00000600,
  All                         = 0x07FFFFFF,
}
