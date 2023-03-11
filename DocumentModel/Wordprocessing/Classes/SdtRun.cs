using System.Collections.Generic;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtRun Class.
/// </summary>
public class SdtRun: SdtElement, ICommonRunElement
{
  /// <summary>
  /// Specifies the last known contents of a structured document tag around one or more inline-level structures 
  /// (runs, DrawingML objects, fields, etc.). This element's contents shall be treated as a cache 
  /// of the contents to be displayed in the structured document tag for the following reasons:
  /// <list type="bullet">
  ///   <item>
  ///     If the structured document tag specifies an XML mapping via the dataBinding element, 
  ///     changes to the custom XML data part shall be reflected in the structured document tag as needed.
  ///   </item>
  ///   <item>
  ///     If the contents of the structured document tag are placeholder text via the showingPlcHdr element, 
  ///     then this content can be updated with the placeholder text stored in the Glossary Document part.
  ///   </item>
  /// </list>
  public SdtContentRun? SdtContentRun { get; set; }

}