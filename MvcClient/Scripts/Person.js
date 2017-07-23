var MvcSamples;
(function (MvcSamples) {
    var Person = (function () {
        function Person(name, birth) {
            this.name = name;
            this.birth = birth;
        }
        Person.prototype.toString = function () {
            return this.name + " " + this.birth.toLocaleDateString();
        };
        return Person;
    }());
    MvcSamples.Person = Person;
})(MvcSamples || (MvcSamples = {}));
var p = new MvcSamples.Person("山田リオ", new Date(2009, 5, 25));
window.alert(p.toString());
//# sourceMappingURL=Person.js.map