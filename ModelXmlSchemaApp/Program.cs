namespace ModelXmlSchemaApp;

using ModelXmlSchema;

internal class Program
{
  static void Main(string[] args)
  {
    var t1 = DateTime.Now;
    var XmlSchemaParser = new XmlSchemaParser();
    XmlSchemaParser.ParseSchemaFiles(@"D:\VS\Docs\OpenXML\Schemas", @"D:\VS\Docs\OpenXML\XmlSchema.accdb");
    var t2 = DateTime.Now;
    var dt = t2 - t1;
    if (dt.TotalMinutes >= 1)
      Console.WriteLine("Done in {0} min {1} sec", (int)dt.TotalMinutes, dt.Seconds);
    else
      Console.WriteLine("Done in {0} seconds", (int)dt.TotalSeconds);
    Console.WriteLine("Found {0} files, added {1}, updated {2}", XmlSchemaParser.SchemaFilesTotal, XmlSchemaParser.SchemaFilesAdded, XmlSchemaParser.SchemaFilesUpdated);
    Console.WriteLine("Found {0} namespaces, added {1}, updated {2}", XmlSchemaParser.NamespacesTotal, XmlSchemaParser.NamespacesAdded, XmlSchemaParser.NamespacesUpdates);
    Console.WriteLine("Found {0} used namespaces, added {1}", XmlSchemaParser.UsedNamespacesTotal, XmlSchemaParser.UsedNamespacesAdded);
    Console.WriteLine("Found {0} simple types, added {1}, updated {2}", XmlSchemaParser.SimpleTypesTotal, XmlSchemaParser. SimpleTypesAdded, XmlSchemaParser. SimpleTypesUpdated);
    Console.WriteLine("Found {0} complex types, added {1}, updated {2}", XmlSchemaParser.ComplexTypesTotal, XmlSchemaParser. ComplexTypesAdded, XmlSchemaParser.ComplexTypesUpdated);
    Console.WriteLine("Found {0} attribute definitions, added {1}, updated {2}", XmlSchemaParser.AttributeDefsTotal, XmlSchemaParser. AttributeDefsAdded, XmlSchemaParser. AttributeDefsUpdated);
    Console.WriteLine("Found {0} attribute references, added {1}, updated {2}", XmlSchemaParser.AttributeRefsTotal, XmlSchemaParser.AttributeRefsAdded, XmlSchemaParser.AttributeRefsUpdated);
    Console.WriteLine("Found {0} attribute groups, added {1}", XmlSchemaParser.AttributeGroupsTotal, XmlSchemaParser. AttributeGroupsAdded);
    Console.WriteLine("Found {0} attribute group refs, added {1}", XmlSchemaParser.AttributeGroupRefsTotal, XmlSchemaParser. AttributeGroupRefsAdded);
    Console.WriteLine("Found {0} particles, added {1}, updated {2}", XmlSchemaParser.ParticlesTotal, XmlSchemaParser. ParticlesAdded, XmlSchemaParser. ParticlesUpdated);
    Console.WriteLine("Found {0} enum values, added {1}", XmlSchemaParser.EnumValuesTotal, XmlSchemaParser. EnumValuesAdded);
    Console.WriteLine("Found {0} patterns, added {1}", XmlSchemaParser.PatternsTotal, XmlSchemaParser. PatternsAdded);
    Console.WriteLine("Found {0} list items, added {1}, updated {2}", XmlSchemaParser.ListItemsTotal, XmlSchemaParser.ListItemsAdded, XmlSchemaParser.ListItemsUpdates);
    Console.WriteLine("Found {0} union members, added {1}, updated {2}", XmlSchemaParser.UnionMembersTotal, XmlSchemaParser.UnionMembersAdded, XmlSchemaParser.UnionMembersUpdates);
    Console.WriteLine("Found {0} groups, added {1}", XmlSchemaParser.GroupsTotal, XmlSchemaParser. ElementGroupsAdded);
    Console.WriteLine("Found {0} group refs, added {1}, updated {2}", XmlSchemaParser.GroupRefsTotal, XmlSchemaParser.GroupRefsAdded, XmlSchemaParser.GroupRefsUpdated);
    Console.WriteLine("Found {0} elements, added {1}, updated {2}", XmlSchemaParser.ElementsTotal, XmlSchemaParser.ElementsAdded, XmlSchemaParser.ElementsUpdated);
}
}
