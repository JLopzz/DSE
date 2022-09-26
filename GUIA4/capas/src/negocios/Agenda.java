package negocios;

import interfazUsuario.interfaz;
import java.util.LinkedList;
import datos.contacto;

public class Agenda {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		interfaz i1 = new interfaz();
		i1.Lectura();
	}

	LinkedList<contacto> lista = new LinkedList<contacto>();
	
	public boolean add(contacto Contacto) {
		char[] letras = Contacto.getNombre().toCharArray();
		if(letras.length >= 0 && letras.length <= 10) {
			String enteroString = Long.toString(Contacto.getCelular());
			letras = enteroString.toCharArray();
			if(letras.length == 8) {
				lista.add(Contacto);
				return true;
			}
		}
		return false;
	}

	public LinkedList<contacto> getLista() {
		return lista;
	}

	public void setLista(LinkedList<contacto> lista) {
		this.lista = lista;
	}


}
