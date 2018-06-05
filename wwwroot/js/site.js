// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

class VPet {

    constructor(id, name, happy, health, hunger, state, sleeping) {
        this.id = id;
        this.name = name;
        this.happy = happy;
        this.health = health;
        this.hunger = hunger;
        this.state = state;
        this.sleeping = sleeping;
        this.sleeping ? this.setSleeping() : this.setAwake();
    }

    get isSleeping() {
        return this.sleeping;
    }

    cure() {
        if (this.state == 'dead') return;
        this.health += 10;
        this.normalize();
        this.updateBars();
    }

    eat() {
        if (this.state == 'dead') return;
        this.hunger += 20;
        this.normalize();
        this.updateBars();
        $("#petimg").attr("src", "https://pa1.narvii.com/5784/0ae4bc6e0f117bbeb463f6f583072fe59cd9c136_hq.gif");
        setTimeout(() => {
            $("#petimg").attr("src", "http://2.bp.blogspot.com/-pEi1Tz0Xj9o/Ui3--vUDuXI/AAAAAAAAAp8/9bMzxDo3Rq8/s1600/tumblr_m1i3b73kEI1r6gk4zo1_500.gif");
        }, 3100)
    }

    setSleeping() {
        $("#petimg").attr("src", "http://rs708.pbsrc.com/albums/ww83/etna-08/smilies/RestingSnorlax.gif~c200");
        this.sleeping = true;
        $('#overlay').fadeToggle(1000);
    }

    setAwake() {
        $("#petimg").attr("src", "http://2.bp.blogspot.com/-pEi1Tz0Xj9o/Ui3--vUDuXI/AAAAAAAAAp8/9bMzxDo3Rq8/s1600/tumblr_m1i3b73kEI1r6gk4zo1_500.gif");
        this.sleeping = false;
    }

    sleep() {
        if (this.state == 'dead') return;
        this.happy += 10;
        this.setSleeping()
        this.normalize();
        this.updateBars();
    }

    awake() {
        this.setAwake();
        $('#overlay').fadeToggle(1000);
    }

    shower() {
        if (this.state == 'dead') return;
        $("#showering").css("visibility", "visible");
        setTimeout(() => {
            $("#showering").css("visibility", "hidden");
        }, 5000)
        this.happy += 5;
        this.health += 5;
        this.normalize();
        this.updateBars();
    }

    play() {
        if (this.state == 'dead') return;
        this.happy += 15;
        this.normalize();
        this.updateBars();
    }

    normalize() {
        if (this.health > 100) this.health = 100;
        if (this.happy > 100) this.happy = 100;
        if (this.hunger > 100) this.hunger = 100;
    }

    update() {

        var updateInterval = setInterval(() => {

            var hungerRate = 1,
                healthRate = 1,
                happyRate = 1;

            if (this.state == 'happy') {
                hungerRate = 1;
                healthRate = 2;
                happyRate = 1;
            }
            if (this.state == 'sad') {
                hungerRate = 3;
                healthRate = 2;
                happyRate = 3;
            }
            if (this.state == 'sick') {
                hungerRate = 1;
                healthRate = 3;
                happyRate = 3;
            }
            this.hunger -= (hungerRate * Math.random() / 10);
            this.health -= (healthRate * Math.random() / 10);
            this.happy -= (happyRate * Math.random() / 10);
            console.log(this.hunger, this.health, this.happy, this.state, this.sleeping);

            this.updateBars();
            this.updateState(updateInterval);

        }, 1000);

    }

    updateBars() {
        $('#hungerBar').css('width', this.hunger + '%');
        $('#healthBar').css('width', this.health + '%');
        $('#happyBar').css('width', this.happy + '%');

        if (this.hunger > 50) {
            $('#hungerBar').removeClass().addClass('progress-bar progress-bar-success');
        } else if (this.hunger > 25) {
            $('#hungerBar').removeClass().addClass('progress-bar progress-bar-warning');
        } else {
            $('#hungerBar').removeClass().addClass('progress-bar progress-bar-danger');
        }

        if (this.health > 50) {
            $('#healthBar').removeClass().addClass('progress-bar progress-bar-success');
        } else if (this.health > 25) {
            $('#healthBar').removeClass().addClass('progress-bar progress-bar-warning');
        } else {
            $('#healthBar').removeClass().addClass('progress-bar progress-bar-danger');
        }

        if (this.happy > 50) {
            $('#happyBar').removeClass().addClass('progress-bar progress-bar-success');
        } else if (this.happy > 25) {
            $('#happyBar').removeClass().addClass('progress-bar progress-bar-warning');
        } else {
            $('#happyBar').removeClass().addClass('progress-bar progress-bar-danger');
        }
    }

    updateState(updateInterval) {
        if (this.happy < 25) this.state = 'sad'
        else if (this.health < 25) this.state = 'sick'
        else if (this.happy <= 0 || this.health <= 0 || this.hunger <= 0) {
            this.state = 'dead';
            clearInterval(updateInterval);
            var r = confirm("Seu Pet Morreu! Deseja reiniciar?");
            if (r) this.restart();
        } else this.state = 'happy'

        $('#state').html('');
        $('#state').html(this.state);
    }

    restart() {
        this.happy = 100;
        this.health = 100;
        this.hunger = 100;
        this.state = 'happy';
        this.update();
    }

    save() {
        $.ajax({
            method: "POST",
            url: "/Home/Pet/" + this.id,
            data: this
        }).done(function( msg ) {
            console.log( msg );
          });
        
    }

}
vpet_id = window.location.pathname.split('/')[3];
var vpet;

$.ajax({
    type: 'GET',
    url: "/Home/Pet/" + vpet_id,
    success: pet => {
        vpet = new VPet(vpet_id, pet.name, pet.happy, pet.health, pet.hunger, pet.state, pet.sleeping);
        vpet.update();
    },
    dataType: "json"
});

$("#cure").on("click", () => {
    vpet.cure()
});

$("#eat").on("click", () => {
    vpet.eat();
});

$("#sleep").on("click", () => {
    vpet.isSleeping ? vpet.awake() : vpet.sleep();
});

$("#shower").on("click", () => {
    vpet.shower();
});

$("#play").on("click", () => {
    vpet.play();
    vpet.save();
});

$(window).on("beforeunload", () => {
    vpet.save();
});