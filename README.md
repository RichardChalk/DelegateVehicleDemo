# Delegates representerar en referens till en metod... 

Att skapa en ny instance är egentligen inte en metod!
Eller?
	new Car()
Se ut som en metod anrop...
Vad är det första som händer när jag skapar en ny instans?
Den anropar konstruktorn... som egentligen är en METOD!



# Is it good practise?
=====================

** vehicleDelegate = () => new Car(); **

Ja, att använda vehicleDelegate = () => new Car(); 
är faktiskt god praxis när det gäller delegerade metoder i C# – 
särskilt när du vill 'dynamiskt bestämma vilken typ' som ska returneras vid 
körning (runtime), och då instansiera ett objekt direkt vid behov.

# Varför det är god praxis?:
## Flexibilitet: 
	Lambda-uttryck som () => new Car() gör koden flexibel eftersom du kan 
	byta ut vilket objekt som skapas vid behov, 
	vilket är användbart i scenarier där typen av fordon kan ändras vid körning. 
	Med en delegat kan du också byta ut vehicleDelegate till något annat, 
	t.ex. () => new Bus(), 
	utan att behöva ändra på fler delar av koden.

## Låg overhead: 
	Att skapa ett objekt (t.ex. new Car()) direkt i ett lambda-uttryck är 
	effektivt och snabbt i C#. 
	Det är en av anledningarna till att lambda-uttryck är populära vid 
	implementering av delegerade metoder som dessa – 
	de ger snabbare kod utan att kompromissa med läsbarheten.

## Användningsfall för enkel konstruktion: 
	När du har objekt utan komplexa beroenden (t.ex. new Car()), 
	är det fullt rimligt att instansiera direkt i en lambda. 
	Detta är vanligt inom Factory pattern-mönster och andra situationer 
	där objekt behöver skapas på begäran.

 # Hur man formattera i en .md fil
 https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax
