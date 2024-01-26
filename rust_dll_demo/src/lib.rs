#[no_mangle]
pub extern "C" fn fireman_add(a: i32, b: i32) -> i32 {
    a + b
}

#[repr(C)]
pub struct Scene {
    pub id: u64,
}

impl Scene {
    fn new(id: u64) -> Self {
        Self { id }
    }
    fn get_id(&self) -> u64 {
        self.id
    }
}

#[no_mangle]
pub extern "C" fn new_scene(id: u64) -> *mut Scene {
    Box::into_raw(Box::new(Scene::new(id)))
}

#[no_mangle]
pub extern "C" fn get_id(my_struct: *const Scene) -> u64 {
    let my_struct = unsafe { &*my_struct };
    my_struct.get_id()
}
