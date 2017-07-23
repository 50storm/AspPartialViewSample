 module MvcSamples {
  export class Person {
    constructor(private name: string, private birth: Date) { }

    public toString(): string {
      return this.name + " " + this.birth.toLocaleDateString();
    }
  }
}

var p = new MvcSamples.Person("山田リオ", new Date(2009, 5, 25));
window.alert(p.toString());
