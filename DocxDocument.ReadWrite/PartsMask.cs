namespace DocxDocument.ReadWrite;
[Flags]
public enum PartsMask : Int64
{
  CoreFileProperties     = 0x000001,
  ExtendedFileProperties = 0x000002,
  CustomFileProperties   = 0x000004,
  DocumentSettings       = 0x000008,
  AllDocumentProperties  = 0x00000F,

  NumberingDefinitions   = 0x000100,
  StyleDefinitions       = 0x000200,
  Theme                  = 0x000400,
  FontTable              = 0x000800,
  EmbeddedFonts          = 0x001800,
  Background             = 0x002000,
  Stylistics             = 0x003F00,

  Comments               = 0x004000,

  Revisions              = 0x008000,
  Bookmarks              = 0x010000,
  RangePermissions       = 0x020000,
  Proofing               = 0x040000,
  InlineAnnotations      = 0x080000,
  AllAnnotations         = 0x0F8000,

  Paragraphs             = 0x100000,
  Body                   = 0xFF8000,

  //HeadersAndFooters           = 0x1000,
  //FootnotesAndEndNotes        = 0x2000,
  //Hyperlinks                  = 0x4000,
  //Bibliography                = 0x8000,

  //Images                    = 0x10000,
  //Diagrams                  = 0x20000,
  //Charts                    = 0x40000,
  //Graphics                  = 0x70000,
  //AudioVideo                = 0x80000,

  //EmbeddedObjects           = 0x100000,
  //EmbeddedPackages          = 0x200000,
  //EmbeddedControls          = 0x400000,
  //Embeddings                = 0x700000,
  //AltFormatImport           = 0x800000,

  //Framesets                 = 0x1000000,
  //Comments                  = 0x2000000,
  //Thubnail                  = 0x4000000,
  //DigitalSignature          = 0x8000000,

  //AdditionalCharacteristics = 0x10000000,
  //ContentParts              = 0x20000000,
  //XSLTransformation         = 0x40000000,
  //Subdocuments              = 0x80000000,

  //MailMergeDataSource       = 0x100000000,
  //MailMergeHeaderDataSource = 0x200000000,
  //MailMerge                 = 0x300000000,


  All = Int64.MaxValue,
}

