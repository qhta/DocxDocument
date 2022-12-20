namespace DocxDocument.Model;

[Flags]
public enum RevisionView
{
    /// <summary> 
    /// Display Comments.
    ///</summary> 
    [XmlEnum("comments")]
    Comments = 1,

    /// <summary> 
    /// Display Content Revisions.
    ///</summary> 
    [XmlEnum("displayRevision")]
    DisplayRevision = 2,

    /// <summary> 
    /// Display Formatting Revisions.
    ///</summary> 
    [XmlEnum("formatting")]
    Formatting = 4,

    /// <summary> 
    /// Display Ink Annotations.
    ///</summary> 
    [XmlEnum("inkAnnotations")]
    InkAnnotations = 8,

    /// <summary> 
    /// Display Visual Indicator Of Markup Area.
    ///</summary> 
    [XmlEnum("markup")]
    Markup = 16,

    /// <summary> 
    /// Display all revisions.
    ///</summary> 
    [XmlEnum("all")]
    All = 31,
}