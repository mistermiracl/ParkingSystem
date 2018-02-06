
USE ParkingSystem
GO

INSERT INTO TB_CLIENTE VALUES('CLI001', 'Jose', 'Perez', 0),
                             ('CLI002', 'Marco', 'Rodriguez', 0),
							 ('CLI003', 'Luis', 'Campos', 0),
							 ('CLI004', 'Juan', 'Lozano', 1),
							 ('CLI005', 'Nicole', 'Galvez', 1),
							 ('CLI006', 'Marta', 'Chavez', 0),
							 ('CLI007', 'Norma', 'Velasquez', 0),
							 ('CLI008', 'Martin', 'Macedo', 0),
							 ('CLI009', 'Eduardo', 'Astocondor', 0),
							 ('CLI010', 'Gabriela', 'Reyes', 1)
GO

INSERT INTO TB_VEHICULO VALUES('VEH001', 'Mitsubishi', 'Outlander','Auto negro nuevo, sin defecto alguno', 'S12-A24', 'CLI001', 'Auto'),
                              ('VEH002', 'BMW', 'Z4','Convertible blanco nuevo, sin defecto alguno', 'A55-EG2', 'CLI002', 'Auto'),
							  ('VEH003', 'Suzuki', 'Burgman','Scooter rojo. nuevo', 'L12-221', 'CLI003', 'Moto'),
							  ('VEH004', 'Mercedes Benz', 'Axor','Se aprecian signos de desgaste, abolladura la parte trasera del furgon', 'OL2-98A', 'CLI004', 'Camion'),
							  ('VEH005', 'Hyundai', 'H100','Camio Blanco, pocos signos de uso, no se presenta defecto grave alguno', 'KI1-042', 'CLI005', 'Camion'),
							  ('VEH006', 'Honda', 'DN-01','Moto color negro no se aprecia mucho uso', 'DD2-A3O', 'CLI006', 'Moto'),
							  ('VEH007', 'Volswagen', 'Escarabajo','Auto Azul con bastante recorrido, sin retrovisor interno, direcional posterior derecha rota', 'M32-V99', 'CLI007', 'Auto'),
							  ('VEH008', 'Kia', 'Rio','Taxi color negro, cubierto por polvo', 'VJ2-5DG', 'CLI008', 'Auto'),
							  ('VEH009', 'Jeep', 'Patriot','Camioneta verde cubierta de lodo al lado derecho, buenas condiciones', 'N2L-9BG', 'CLI009', 'Auto'),
							  ('VEH010', 'Audi', 'Q5','Auto Morado nuevo, sin defecto alguno', 'PF2-W21', 'CLI010', 'Auto')
GO

INSERT INTO TB_EMPLEADO VALUES('EMP001', 'Javier', 'Yaipen', '5332211', 'jyaipen88@hotmail.com', 'Jr. Huso 213', 2, 4, 63342266),
                              ('EMP002', 'Ronda', 'Piñeda', '922233221', 'rpiñeda91@hotmail.com', 'Av. SiempreViva 4221', 2, 4, 10234422),
							  ('EMP003', 'Diana', 'Barona', '943933991', 'dbarona79@outlook.com', 'Psj. Arañas 9842', 3, 1, 92102211),
							  ('EMP004', 'Andrea', 'Chang', '933122331', 'achang89@yahoo.com', 'Jr. Los Huertos 833', 1, 1, 92102255),
							  ('EMP005', 'Miguel', 'Rosado', '4225385', 'mrosado88@outlook.com', 'Av. Lomas 383', 1, 6, 20329911),
							  ('EMP006', 'William', 'Medina', '983412233', 'wmedina93@gmail.com', 'Av. Manta 553', 1, 2, 38421122),
							  ('EMP007', 'Hector', 'Caycho', '993483311', 'hcaycho95@gmail.com', 'Av. Lurco 5543', 1, 2, 73022299),
							  ('EMP008', 'Graciela', 'Huaman', '8445933', 'ghuaman87@gmail.com', 'Calle Ramsa 987', 3, 3, 79480022),
							  ('EMP009', 'Brenda', 'Alarcon', '933433882', 'balarcon89@gmail.com', 'Jr. Huri 764', 3, 2, 84282211),
							  ('EMP010', 'Pia', 'Menendez', '990213343', 'pmenendez94@hotmail.com', 'Psj. Los Retoños 121', 3, 4, 38123377)
GO

DECLARE @CHAR CHAR(6)
SET @CHAR = '1'
SELECT @CHAR
GO

EXEC usp_ListarClientes
GO

EXEC usp_ListarVehiculos
GO

EXEC usp_ListarEmpleados
GO

--DELETE TB_CLIENTE
--GO

--DELETE TB_ABONADO
--GO

--DELETE TB_VEHICULO
--GO

--DELETE TB_EMPLEADO
--GO


