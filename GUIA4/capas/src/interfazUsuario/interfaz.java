package interfazUsuario;

import java.util.Scanner;
import datos.contacto;
import negocios.Agenda;


public class interfaz {
	static Scanner entrada = new Scanner(System.in);
	static Agenda Libro = new Agenda();
	public static void Lectura() {
		System.out.println("Bienvenido");
		System.out.println("Elija una opcion");
		
		imprimirMenu();
	}
	private static void validar() {
		System.out.println("Ingresas nuevo contacto");
		System.out.println("Ingrese la informacion del contacto");
		System.out.println("El nombre debe contener maximo 10 caracteres");
		System.out.println("El celular contiene 8 digitos");
		contacto Contacto = new contacto();
		System.out.println("Nombre: ");
		Contacto.setNombre(entrada.next());
		System.out.println("Telefono: : ");
		Contacto.setCelular(entrada.nextLong());
		if(Libro.add(Contacto) == true) {
			System.out.println("El contacto ha sido ingresado con exito");
		} else {
			System.out.println("Error al ingresar los datos");
			System.out.println("Si desea agregar un contacto mas, elija la opcion 1");
		}
		imprimirMenu();
	}
	private static void mostrarContactos() {
		Libro.getLista().forEach((el) -> System.out.println(el.toString()) );
		imprimirMenu();
	}
	private static void salir() {
		System.out.println("Fin de la Ejecucion");
		System.exit(0);
	}
	private static void imprimirMenu() {
		System.out.println("Bienvenido");
		System.out.println("Eliija una opcion");
		System.out.println("1. Nuevo contacto");
		System.out.println("2. Contactos");
		System.out.println("3. Salir");
		
		int opcion = entrada.nextInt();
		switch(opcion) {
		case 1: validar(); break;
		case 2: mostrarContactos(); break;
		case 3: salir(); break;
		default: System.out.println("Opcion Invalida"); break;
		}
	}
}
