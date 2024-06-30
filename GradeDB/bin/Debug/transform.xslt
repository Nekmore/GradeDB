<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<head>
				<style>
					body { font-family: Arial, sans-serif; }
					table { width: 100%; border-collapse: collapse; }
					th, td { border: 1px solid black; padding: 8px; text-align: left; }
					th { background-color: #f2f2f2; }
				</style>
			</head>
			<body>
				<h2>Отчет по студентам</h2>
				<table>
					<tr>
						<th>ID студента</th>
						<th>ФИО студента</th>
						<th>Дата рождения</th>
						<th>ID группы</th>
					</tr>
					<xsl:for-each select="students/student">
						<tr>
							<td>
								<xsl:value-of select="idStudent"/>
							</td>
							<td>
								<xsl:value-of select="FIOstudenst"/>
							</td>
							<td>
								<xsl:value-of select="DateBirth"/>
							</td>
							<td>
								<xsl:value-of select="Group_idGroup"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>
