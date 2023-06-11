Prihlasovacie údaje:
 admin : admin
admin2 : password

Asynchrónnosť by mala byť pozorovateľná najjednoduchšie s odkomentovanými delay-mi v:
 Model/Common/AppContext.cs:LoadAllAppData() - pri načítavaní súborov po prihlásení
	bude potrebne refreshnúť list v MainForm-e pomocou prepínania medzi hráčmi a turnajmi;
 Controller/Common/MatchTreeGenerator.cs:GenerateMatchTree() - pri generovaní pavúka zápasov.