using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[Guid("BFFE8F80-6A67-4B7A-AEAA-8823E7932C87")]
[TypeLibType(16)]
public enum XlCategoryLabelLevel
{
  xlCategoryLabelLevelNone = -3,
  xlCategoryLabelLevelCustom,
  xlCategoryLabelLevelAll
}