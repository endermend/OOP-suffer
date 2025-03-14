
string number0 = "880";
string number1 = "860";
string number2 = "834";
string name0 = "Smith";
string name1 = "Samuel";
string name2 = "Joseph";

Phone ph0 = new Phone(number0);
Phone ph1 = new Phone(number1);
Phone ph2 = new Phone(number2);

Operator op = new Operator();
op.AddPhones(ph0);
op.AddPhones(ph1, ph2);

ph0.AddContact(number1, name1);
ph0.AddContact(number2, name2);
ph1.AddContact(number0, name0);

op.MakeACall(ph0.CallByName("Samuel"));
op.MakeACall(ph0.CallByNumber("860"));
op.MakeACall(ph1.CallByName("Smith"));
op.MakeACall(ph1.CallByNumber("834"));
op.MakeACall(ph2.CallByName("Smith"));
op.MakeACall(ph2.CallByNumber("000"));