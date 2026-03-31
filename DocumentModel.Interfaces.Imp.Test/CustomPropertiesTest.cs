namespace DocumentModel.InOpenXml.Test
{
	/// <summary>
	/// Comprehensive serialization test for DocumentModel.CustomProperties.
	/// </summary>
	public static class CustomPropertiesTest
	{
		/// <summary>
		/// Runs all CustomProperties serialization tests.
		/// </summary>
		/// <returns>True if all tests pass; otherwise, false.</returns>
		public static bool Run()
		{
			Console.WriteLine("=== CustomProperties Test ===\n");
			if (!TestStoreInDocument()) return false;
			if (!TestUpdateInDocument()) return false;
			Console.WriteLine("All CustomProperties tests passed.\n");
			return true;
		}

    /// <summary>
		/// Tests setting sample custom properties to a new document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document custom properties can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document custom properties are successfully stored and verified; otherwise, false.</returns>
		static bool TestStoreInDocument()
		{
			Console.WriteLine("--- Store sample custom properties in new document---");
			{
				CustomProperties testData = CreateSampleCustomProperties();
				using (var document = new Document("temp.docx", FileMode.CreateNew))
				{
					document.CustomProperties = testData;
				}

				CustomProperties storedData;
				using (var document = new Document("temp.docx"))
				{
					storedData = document.CustomProperties ?? throw new InvalidOperationException("Custom properties not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(CustomProperties));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("custom properties stored to new document and reloaded from it:\n" + xmlString);

				if (!TestHelper.CompareTestData(testData, storedData, out var propName))
				{
					Console.WriteLine($"✗ Store sample custom properties test FAILED - data mismatch in '{propName}'");
					return false;
				}

				Console.WriteLine("✓ Store sample custom properties test passed\n");
				return true;
			}
		}


		/// <summary>
		/// Tests updating the custom properties of a document and outputs the result to the console.
		/// </summary>
		/// <remarks>This method is intended for use in test scenarios to verify that document custom properties can
		/// be set and serialized correctly. It writes status messages and the serialized properties to the console for
		/// inspection.</remarks>
		/// <returns>true if the document custom properties are successfully updated and verified; otherwise, false.</returns>
		static bool TestUpdateInDocument()
		{
			Console.WriteLine("--- Update document custom properties ---");
			{
				CustomProperties testData = CreateSampleCustomProperties();
				var initialCount = testData.Count;
        var newCustomProperty = new CustomProperty { Name = "CustomTitle", Value = "Updated Title" };

        using (var document = new Document("temp.docx", FileMode.CreateNew))
				{
					document.CustomProperties = testData;

					document.CustomProperties.Add(newCustomProperty);
				}

				CustomProperties storedData;
				using (var document = new Document("temp.docx"))
				{
					storedData = document.CustomProperties ?? throw new InvalidOperationException("Custom properties not found.");
				}

				var xmlSerializer = new XmlSerializer(typeof(CustomProperties));
				string xmlString;
				using (var stringWriter = new StringWriter())
				using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
				{
					xmlSerializer.Serialize(xmlWriter, storedData);
					xmlString = stringWriter.ToString();
				}
				Console.WriteLine("Updated document custom properties:\n" + xmlString);

				var storedCount = storedData.Count;
				if (storedCount != initialCount + 1)
				{
					Console.WriteLine($"✗ Updated document custom properties test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
					return false;
				}
        var storedCustomProperty = storedData.Last();
				if (!TestHelper.CompareTestData(newCustomProperty, storedCustomProperty, out var propName))
        {
          Console.WriteLine($"✗ Store sample custom properties test FAILED - data mismatch in new item '{propName}'");
          return false;
        }

        Console.WriteLine("✓ Updated document custom properties test passed\n");
				return true;
			}
		}


		/// <summary>
		/// Creates a sample CustomProperties object with various property types.
		/// </summary>
		/// <returns>A populated CustomProperties object.</returns>
		static CustomProperties CreateSampleCustomProperties()
		{
			var props = new CustomProperties();
			props.Add(new CustomProperty
			{
				Name = "CustomString",
				Value = "Test String"
			});
			props.Add(new CustomProperty
			{
				Name = "CustomInt",
				Value = 123
			});
			props.Add(new CustomProperty
			{
				Name = "CustomBool",
				Value = true
			});
			props.Add(new CustomProperty
			{
				Name = "CustomDate",
				Value = DateTime.Parse("2026-01-17T10:00:00Z")
			});

			return props;
		}

		/// <summary>
		/// Serializes a CustomProperties object to an XML string.
		/// </summary>
		/// <param name="props">The CustomProperties object to serialize.</param>
		/// <returns>The serialized XML string.</returns>
		static string SerializeToXml(CustomProperties props)
		{
			var xmlSerializer = new XmlSerializer(typeof(CustomProperties));
			using (var stringWriter = new StringWriter())
			using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
			{
				xmlSerializer.Serialize(xmlWriter, props);
				return stringWriter.ToString();
			}
		}

		/// <summary>
		/// Deserializes a CustomProperties object from an XML string.
		/// </summary>
		/// <param name="xml">The XML string to deserialize.</param>
		/// <returns>The deserialized CustomProperties object, or null if deserialization fails.</returns>
		static CustomProperties? DeserializeFromXml(string xml)
		{
			var xmlSerializer = new XmlSerializer(typeof(CustomProperties));
			using (var stringReader = new StringReader(xml))
			{
				return (CustomProperties?)xmlSerializer.Deserialize(stringReader);
			}
		}

		/// <summary>
		/// Serializes a CustomProperties object to a JSON string.
		/// </summary>
		/// <param name="props">The CustomProperties object to serialize.</param>
		/// <returns>The serialized JSON string.</returns>
		static string SerializeToJson(CustomProperties props)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Serialize(props, jsonOptions);
		}

		/// <summary>
		/// Deserializes a CustomProperties object from a JSON string.
		/// </summary>
		/// <param name="json">The JSON string to deserialize.</param>
		/// <returns>The deserialized CustomProperties object, or null if deserialization fails.</returns>
		static CustomProperties? DeserializeFromJson(string json)
		{
			var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
			return JsonSerializer.Deserialize<CustomProperties>(json, jsonOptions);
		}
	}
}