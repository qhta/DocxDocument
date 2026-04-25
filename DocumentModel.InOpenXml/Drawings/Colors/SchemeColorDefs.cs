namespace DocumentModel.Drawings;

/// <summary>
/// Collection of <see cref="SchemeColorDef"/> elements, representing a collection of scheme color definitions that can be used in themes and color schemes within the document model. Each <see cref="SchemeColorDef"/> in the collection defines a specific scheme color that can be referenced by drawing elements to ensure consistent color usage across the document. This collection allows for the organization and management of multiple scheme color definitions within a theme or color scheme context.
/// </summary>
public class SchemeColorDefs: ModelElementCollection<SchemeColorDef>
{

}