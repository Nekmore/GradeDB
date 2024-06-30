<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<head>
				<title>Report</title>
			</head>
			<body>
				<h1>Generated Report</h1>
				<ul>
					<xsl:for-each select="root/child">
						<li>
							<xsl:value-of select="."/>
						</li>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>
